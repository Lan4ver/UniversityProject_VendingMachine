using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Projekt1_Podorozhnyi50402
{
    public partial class Form1 : Form
    {
        private double mPPayedBalance = 0;
        private double mPBalance = 0;
        private List<Button> mPProducBtn;
        private List<Button> mPCurBtn;

        public Form1()
        {
            InitializeComponent();
            mPProducBtn = new List<Button> { btnLT, btnRT, btnLB, btnRB };
            mPCurBtn = new List<Button> { btnCurrP, btnCurrJ, btnCurrD, btnCurrPe };
        }
        private void productButtonClicked(object sender, EventArgs e)
        {
            var currentButton = sender as Button;
            mPChangeBalanceByButton(currentButton);
            mPShowBalance(txtToPay, mPBalance);
            mPDisableProductButtons();
            mPEnablePayingService();
        }
        private void currencyButtonClicked(object sender, EventArgs e)
        {
            var currentButton = sender as Button;
            mPChangePayedBalanceByButton(currentButton);
            mPShowBalance(txtPayed, mPPayedBalance);
        }
        private void PayCashBtnClicked(object sender, EventArgs e)
        {
            if (mPBalance > mPPayedBalance)
            {
                MessageBox.Show("ERROR");
                return;
            }

            MessageBox.Show($"Reszta - {mPPayedBalance - mPBalance}!");

            Reset();
        }

        private void PayByCardButtonClicked(object sender, EventArgs e)
        {
            MessageBox.Show("Koniec");

            Reset();
        }

        private void Reset()
        {
            cmbSP.Enabled = false;
            btnKardPay.Enabled = false;
            mPCurBtn.ForEach(x => x.Enabled = false);
            mPProducBtn.ForEach(x => x.Enabled = true);
            cmbSP.Enabled = false;
            btnPay.Enabled = false;
            txtToPay.Text = "0";
            txtPayed.Text = "0";
        }

        private void mPChangeBalanceByButton(Button currentButton)
        {
            if (currentButton == btnLT)
                mPBalance = 5;
            else if (currentButton == btnRT)
                mPBalance = 3.5;
            else if (currentButton == btnLB)
                mPBalance = 2;
            else if (currentButton == btnRB)
                mPBalance = 1;
        }

        private void mPChangePayedBalanceByButton(Button currentButton)
        {
            if (currentButton == btnCurrP)
                mPPayedBalance += 0.5;
            else if (currentButton == btnCurrJ)
                mPPayedBalance += 1;
            else if (currentButton == btnCurrD)
                mPPayedBalance += 2;
            else if (currentButton == btnCurrPe)
                mPPayedBalance += 5;
        }

        private void mPEnablePayingService()
        {
            cmbSP.Enabled = true;
            mPPayType(cmbSP.SelectedIndex);
        }

        private void mPShowBalance(TextBox textBox, double balance)
        {
            textBox.Text = $"{balance} {this.cmbWaluta.GetItemText(this.cmbWaluta.SelectedItem)}";
        }

        private void mPDisableProductButtons()
        {
            mPProducBtn.ForEach(x => x.Enabled = false);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSP.SelectedIndex == -1)
                return;

            mPPayType(cmbSP.SelectedIndex);
        }

        private void mPPayType(int type)
        {
            if (type == 0)
            {
                mPEnableCardPaying();
            }
            else
            {
                mPEnableCashPaying();
            }
        }

        private void mPEnableCashPaying()
        {
            mPCurBtn.ForEach(x => x.Enabled = true);
            btnKardPay.Enabled = false;
            btnPay.Enabled = true;
        }

        private void mPEnableCardPaying()
        {
            mPCurBtn.ForEach(x => x.Enabled = false);
            btnKardPay.Enabled = true;
            btnPay.Enabled = false;
        }

    }
}
