using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class FrmCalc : Form
    {
        enum eArithmetic
        {
            Div,    // ÷
            Multi,  // ×
            Sub,    // -
            Add,    // +
            None    // 何も押されていない
        }

        eArithmetic gArithmetic;
        decimal gVal1;

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
            Button btn = (Button)sender;

            decimal iNum = decimal.Parse(this.txtResult.Text + btn.Text);
            this.txtResult.Text = iNum.ToString();
        }

        /// <summary>
        /// 四則演算子が押された時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnArithmetic_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            switch (gArithmetic)
            {
                case eArithmetic.Div:
                    gArithmetic = eArithmetic.Div;
                    break;
                case eArithmetic.Multi:
                    gArithmetic = eArithmetic.Multi;
                    break;
                case eArithmetic.Sub:
                    gArithmetic = eArithmetic.Sub;
                    break;
                case eArithmetic.Add:
                    gArithmetic = eArithmetic.Add;
                    break;
                default:
                    break;
            }

            gVal1 = decimal.Parse(this.txtResult.Text);
            this.txtResult.Text = "0";
        }

        /// <summary>
        /// イコールが押された時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEq_Click(object sender, EventArgs e)
        {
            decimal val2 = decimal.Parse(this.txtResult.Text);
            decimal valResult = 0;

            switch (gArithmetic)
            {
                case eArithmetic.Div:
                    valResult = gVal1 / val2;
                    break;
                case eArithmetic.Multi:
                    valResult = gVal1 * val2;
                    break;
                case eArithmetic.Sub:
                    valResult = gVal1 - val2;
                    break;
                case eArithmetic.Add:
                    valResult = gVal1 + val2;
                    break;
                default:
                    break;
            }

            this.txtResult.Text = valResult.ToString();
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
            this.txtResult.Text = "0";
            gArithmetic = eArithmetic.None;
            gVal1 = 0;
        }
    }
}
