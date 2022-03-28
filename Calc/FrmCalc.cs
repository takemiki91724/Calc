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
            Max
        }

        Arithmetic _arithmetic;

        string _input_str;  // 入力された数字
        decimal _result;    // 計算結果

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
            var text = btn.Text;

            // [入力された数字]に連結する
            _input_str += text;

            // 画面上に数字を出す
            this.txtResult.Text = _input_str;
        }

        /// <summary>
        /// 四則演算子が押された時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnArithmetic_Click(object sender, EventArgs e)
        {
            var num1 = _result; // 現在の結果
            decimal num2;       // 入力された文字

            // 入力された文字が空欄なら、計算をスキップする
            if (!string.IsNullOrEmpty(_input_str) && _arithmetic != Arithmetic.Max)
            {
                // 入力した文字を数字に変換
                num2 = decimal.Parse(_input_str);

                // 四則計算
                _result = Calcurate(num1, num2);
            }
            else
            {
                _result = decimal.Parse(this.txtResult.Text);
            }

            // 画面に計算結果を表示する
            this.txtResult.Text = _result.ToString();

            // 今入力されている数字をリセットする
            _input_str = "";

            // 演算子をOperator変数に入れる
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
            decimal num2;       // 入力された文字

            // 入力された文字が空欄なら、計算をスキップする
            if (!string.IsNullOrEmpty(_input_str))
            {
                // 入力した文字を数字に変換
                num2 = decimal.Parse(_input_str);
            }
            else
            {
                num2 = decimal.Parse(this.txtResult.Text);
            }

            // 四則計算
            _result = Calcurate(num1, num2);

            // 画面に計算結果を表示する
            this.txtResult.Text = _result.ToString();

            // 今入力されている数字をリセットする
            _input_str = null;

            // 演算子をArithmetic.Maxにする
            _arithmetic = Arithmetic.Max;
        }

        /// <summary>
        /// クリアボタンが押された時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            Init();
        }

        /// <summary>
        /// 初期化する
        /// </summary>
        private void Init()
        {
            _input_str = "";                // 入力された数字
            _result = 0;                    // 計算結果
            _arithmetic = Arithmetic.Max;   // 押された演算子
            this.txtResult.Text = "0";
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
            Arithmetic arithmetic = Arithmetic.Max;

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
