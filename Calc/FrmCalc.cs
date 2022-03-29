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

        Arithmetic _arithmetic;

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
            txtResult.Text = _input_str;
        }

        /// <summary>
        /// 四則演算子が押された時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnArithmetic_Click(object sender, EventArgs e)
        {
            // 四則計算
            _result = (!string.IsNullOrEmpty(_input_str) && _arithmetic != Arithmetic.None) ? 
                Calcurate(_result, decimal.Parse(_input_str)) : 
                decimal.Parse(txtResult.Text);

            // 画面に計算結果を表示する
            txtResult.Text = _result.ToString();

            _lastNum = string.IsNullOrEmpty(_input_str) ? _result.ToString() : _input_str; 

            // 今入力されている数字をリセットする
            _input_str = "";

            // 演算子をarithmetic変数に入れる
            var btn = (Button)sender;
            _arithmetic = GetArithmetic(btn.Text);
        }

        /// <summary>
        /// イコールが押された時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEq_Click(object sender, EventArgs e)
        {
            var num1 = _result; // 現在の結果

            // 入力された数字が空欄でないなら[入力された数字]、空欄なら[直前に入力された数字]を取得する
            decimal num2 = !string.IsNullOrEmpty(_input_str) ? decimal.Parse(_input_str) : decimal.Parse(_lastNum);

            // [/=]とクリックした場合、num1に[1]を代入する
            if (string.IsNullOrEmpty(_input_str) && _arithmetic == Arithmetic.Div)
                num1 = 1;

            if (string.IsNullOrEmpty(_input_str))
            {
                /*
                // [/=]とクリックした場合、num1に[1]を代入する
                if (_arithmetic == Arithmetic.Div)
                    num1 = 1;
                // [-=]とクリックした場合、num1に[1]を代入する
                if (_arithmetic == Arithmetic.Sub)
                {
                    if (_IsFirstInput)
                    {
                        //num2 = 20;
                        num2 = decimal.Parse(txtResult.Text) * 2;
                        _IsFirstInput = false;
                    }
                }
                */

                switch (_arithmetic)
                {
                    case Arithmetic.Div:
                        num1 = 1;
                        break;
                    case Arithmetic.Sub:
                        if (_IsFirstInput)
                        {
                            num2 = decimal.Parse(txtResult.Text) * 2;
                            _IsFirstInput = false;
                        }
                        break;
                }
            }

            // 四則計算
            _result = Calcurate(num1, num2);

            // 画面に計算結果を表示する
            txtResult.Text = _result.ToString();

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
            _IsFirstInput = true;           // 初回入力フラグ
            txtResult.Text = "0";
        }

        /// <summary>
        /// 計算する
        /// </summary>
        /// <param name="num1">数値1</param>
        /// <param name="num2">数値2</param>
        /// <returns>計算結果</returns>
        private decimal Calcurate(decimal num1, decimal num2)
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

            return _result;
        }

        /// <summary>
        /// 四則演算子を取得する
        /// </summary>
        /// <param name="text">四則演算子ボタンのText値</param>
        /// <returns>四則演算子</returns>
        private Arithmetic GetArithmetic(string text)
        {
            var arithmetic = Arithmetic.None;

            switch (text)
            {
                case "÷":
                    arithmetic = Arithmetic.Div;
                    break;
                case "×":
                    arithmetic = Arithmetic.Multi;
                    break;
                case "-":
                    arithmetic = Arithmetic.Sub;
                    break;
                case "+":
                    arithmetic = Arithmetic.Add;
                    break;
            }

            return arithmetic;
        }
    }
}
