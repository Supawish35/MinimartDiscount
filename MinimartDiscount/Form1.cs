namespace MinimartDiscount;

public partial class Form1 : Form {
    public Form1() {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e) {
        //? Validate input value
        Double.TryParse(txtPurchaseInput.Text, out double price);
        
        //! output section
        //* txtPurchase
        //* txtLevel
        //* txtDiscount
        //* txtTotalAmount
        //* txtSuggestion
        //* ckbMember
        
        //? Create bill obj
        Bill bill = new Bill(price, ckbMember.Checked);

        bill.CalculateDiscount();
        
        txtPurchase.Text = "฿" + price.ToString("F2");
        txtLevel.Text = bill.Level;
        txtDiscount.Text = "฿" + bill.Discount.ToString("F2");
        txtTotalAmount.Text = "฿" + (price - bill.Discount).ToString("F2");
        txtSuggestion.Text = bill.Suggestion;
    }

    
}