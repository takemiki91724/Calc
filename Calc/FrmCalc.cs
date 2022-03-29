using System;
using System.Windows.Forms;

namespace Calc
{
    public partial class FrmCalc : Form
    {
        /// <summary>
        /// 演算子
        /// </summary>
        enum Arithmetic
        {
            Div,    // 割り算
            Multi,  // 掛け算
            Sub,    // 引き算
            Add,    // 足し算
            None    // 何も選択していない
        }

        /// <summary>
        /// 記号
        /// </summary>
        enum Symbol
        {
            DecimalPoint,   // 小数点
            None            // 何も選択していない
        }

        Arithmetic _arithmetic;
        Symbol _symbol;

        string _input_str;  // 入力された数字
        string _lastNum;    // 直前に入力された数字
        decimal _result;    // 計算結果
        bool _IsFirstInput; // 初回入力フラグ

        public FrmCalc()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// 数字が押された時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNum_Click(object sender, EventArgs e)
        {
            // senderの詳しい情報を取り扱えるようにする
            var btn = (Button)sender;

            // 押されたボタンの数字(または小数点の記号)
            var btnNumText = btn.Text;

            // [入力された数字]に連結する
            _input_str += btnNumText;

            // 画面上に数字を出す
            txtResult.Text = ConvertToStringSeparatedByThreeDigits(decimal.Parse(_input_str));
        }

        /// <summary>
        /// 記号が押された時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSymbol_Click(object sender, EventArgs e)
        {
            // senderの詳しい情報を取り扱えるようにする
            var btn = (Button)sender;

            // 記号の種類を取得する
            GetSymbol(btn.Text);

            // 記号に対応する処理を行う
            HandleSymbols();
        }

        /// <summary>
        /// 四則演算子が押された時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnArithmetic_Click(object sender, EventArgs e)
        {
            // 四則計算
            if (!string.IsNullOrEmpty(_input_str) && _arithmetic != Arithmetic.None)
                Calcurate(_result, decimal.Parse(_input_str));
            else
                _result = decimal.Parse(DeleteString(txtResult.Text, ","));

            // 画面に計算結果を表示する
            txtResult.Text = ConvertToStringSeparatedByThreeDigits(_result);

            _lastNum = string.IsNullOrEmpty(_input_str) ? _result.ToString() : _input_str; 

            // 今入力されている数字をリセットする
            _input_str = "";

            // 演算子をarithmetic変数に入れる
            var btn = (Button)sender;
            GetArithmetic(btn.Text);

            _IsFirstInput = true;
        }

        /// <summary>
        /// イコールが押された時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEq_Click(object sender, EventArgs e)
        {
            var num1 = _result; // 現在の結果
            decimal num2;

            // 入力された数字が空欄でないなら[入力された数字]、空欄なら[直前に入力された数字]を取得する
            if (!string.IsNullOrEmpty(_input_str))
                num2 = decimal.Parse(_input_str);
            else
                num2 = decimal.Parse(_lastNum);

            if (string.IsNullOrEmpty(_input_str))
            {
                switch (_arithmetic)
                {
                    case Arithmetic.Div:
                        // [/=]とクリックした場合、num1に[1]を代入する
                        if (_IsFirstInput) num1 = 1;
                        break;
                    case Arithmetic.Sub:
                        // [-=]とクリックした場合、表示されている数字の２倍を代入する
                        var numString = DeleteString(txtResult.Text, ",");
                        if (_IsFirstInput)
                            num2 = decimal.Parse(numString) * 2;
                        break;
                    default:
                        _IsFirstInput = true;
                        break;
                }

                if (_arithmetic == Arithmetic.Div || _arithmetic == Arithmetic.Sub)
                    _IsFirstInput = false;
            }

            // 四則計算
            Calcurate(num1, num2);

            // 画面に計算結果を表示する
            txtResult.Text = ConvertToStringSeparatedByThreeDigits(_result);

            // 今入力されている数字をリセットする
            _input_str = "";
        }

        /// <summary>
        /// クリアボタンが押された時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e) => Init();

        /// <summary>
        /// 初期化する
        /// </summary>
        private void Init()
        {
            _input_str = "";                // 入力された数字
            _lastNum = "";                  // 直前に入力された数字
            _result = 0;                    // 計算結果
            _arithmetic = Arithmetic.None;  // 押された演算子
            _symbol = Symbol.None;          // 押された記号
            _IsFirstInput = true;           // 初回入力フラグ
            txtResult.Text = "0";
        }

        /// <summary>
        /// 計算する
        /// </summary>
        /// <param name="num1">数値1</param>
        /// <param name="num2">数値2</param>
        /// <returns>計算結果</returns>
        private void Calcurate(decimal num1, decimal num2)
        {
            switch (_arithmetic)
            {
                case Arithmetic.Div:
                    _result = num1 / num2;
                    break;
                case Arithmetic.Multi:
                    _result = num1 * num2;
                    break;
                case Arithmetic.Sub:
                    _result = num1 - num2;
                    break;
                case Arithmetic.Add:
                    _result = num1 + num2;
                    break;
                default:
                    // 演算子を押されていなかった場合、入力されている文字をそのまま結果扱いにする
                    _result = num2;
                    break;
            }
        }

        /// <summary>
        /// 四則演算子を取得する
        /// </summary>
        /// <param name="text">四則演算子ボタンのText値</param>
        /// <returns>四則演算子</returns>
        private void GetArithmetic(string text)
        {
            switch (text)
            {
                case "÷":
                    _arithmetic = Arithmetic.Div;
                    break;
                case "×":
                    _arithmetic = Arithmetic.Multi;
                    break;
                case "-":
                    _arithmetic = Arithmetic.Sub;
                    break;
                case "+":
                    _arithmetic = Arithmetic.Add;
                    break;
            }
        }

        /// <summary>
        /// 記号の種類を取得する
        /// </summary>
        /// <param name="text">記号ボタンのText値</param>
        private void GetSymbol(string text)
        {
            switch (text)
            {
                case "・":
                    _symbol = Symbol.DecimalPoint;
                    break;
            }
        }

        /// <summary>
        /// 記号に対応する処理を行う
        /// </summary>
        private void HandleSymbols()
        {
            switch (_symbol)
            {
                case Symbol.DecimalPoint:
                    HandleDecimalPoint();
                    break;
            }
        }

        /// <summary>
        /// 小数点を処理する
        /// </summary>
        private void HandleDecimalPoint()
        {
            // [入力された数字]に連結する
            _input_str += ".";

            // 画面上に数字を出す
            txtResult.Text = ConvertToStringSeparatedByThreeDigits(decimal.Parse(_input_str)); ;
        }

        /// <summary>
        /// ３桁区切りの文字列に変換する
        /// </summary>
        /// <param name="num">変換する数値</param>
        /// <returns>３桁区切りの文字列</returns>
        private string ConvertToStringSeparatedByThreeDigits(decimal num)
        {
            // 整数部を取得する
            decimal integerPart = GetIntegerPartOfNumber(num);

            // numが小数の場合、小数部を取得する
            decimal fractionalPart = 0;
            if (num.ToString().IndexOf(".") > 0)
                fractionalPart = GetFractionalPartOfNumber(num);

            // 整数部を３桁区切りにする
            var strResultNum = string.Format("{0:#,0}", integerPart);

            // 小数部がある場合は連結する
            if (fractionalPart > 0)
                strResultNum += fractionalPart.ToString().Substring(1);

            return strResultNum;
        }

        /// <summary>
        /// 数値の整数部を取得する
        /// </summary>
        /// <param name="num">数値</param>
        /// <returns>整数部の数値</returns>
        private decimal GetIntegerPartOfNumber(decimal num) => Math.Truncate(num);

        /// <summary>
        /// 数値の小数部を取得する
        /// </summary>
        /// <param name="num">数値</param>
        /// <returns>小数部の数値</returns>
        private decimal GetFractionalPartOfNumber(decimal num) => num % 1;

        /// <summary>
        /// 文字列を削除する
        /// </summary>
        /// <param name="target">対象文字列</param>
        /// <param name="deleteString">削除する文字列</param>
        /// <returns>削除済み文字列</returns>
        private string DeleteString(string target, string deleteString) =>
            target.Replace(deleteString, "");
    }
}
