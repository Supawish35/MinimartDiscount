namespace MinimartDiscount;

public class Bill {
    private double Price { get; set; }
    public String Level { get; set; }
    public Double Discount { get; set; }
    public String Suggestion { get; set; }
    public Boolean IsMember { get; set; }

    public Bill(Double price, bool isMember) {
        this.Price = price;
        this.Level = "No discount";
        this.Discount = 0;
        this.Suggestion = "";
        this.IsMember = isMember;
    }

    public void CalculateDiscount(double price) {
        this.Price = price;
        String level = "";
        Double discount = 0;
        Double memberDiscount = 0;
        String memberLevel = "";

        if (IsMember && price >= 500) {
            memberDiscount = 0.05;
            memberLevel = "+ member discount 5%";
        }

        if (price >= 5000) {
            level = "Platinum 20%" + memberLevel;
            discount = price * (0.20 + memberDiscount);
        }

        if (price < 5000) {
            level = "Gold 15%" + memberLevel;
            discount = price * (0.15 + memberDiscount);
            Suggestion = $"Buy more {5000 - price} to get 20% discount";
        }

        if (price < 3000) {
            level = "Silver 10%" + memberLevel;
            discount = price * (0.10 + memberDiscount);
            Suggestion = $"Buy more {3000 - price} to get 15% discount";
        }

        if (price < 1000) {
            level = "Bronze 5%" + memberLevel;
            discount = price * (0.05 + memberDiscount);
            Suggestion = $"Buy more {1000 - price} to get 10% discount";
        } 
        
        if (price < 500) {
            level = "No discount";
            Suggestion = $"Buy more {500 - price} to get 5% discount";
        }

        this.Level = level;
        this.Discount = discount;
    }

    public void CalculateDiscount() {
        String level = "";
        Double discount = 0;
        Double memberDiscount = 0;
        String memberLevel = "";

        if (IsMember) {
            memberDiscount = 0.05;
            memberLevel = "+ member discount 5%";
        }

        if (Price >= 5000) {
            level = "Platinum 20%" + memberLevel;
            discount = Price * (0.20 + memberDiscount);
        }

        if (Price >= 3000) {
            level = "Gold 15%" + memberLevel;
            discount = Price * (0.15 + memberDiscount);
            Suggestion = $"Buy more {5000 - Price} to get 20% discount";
        }

        if (Price >= 1000) {
            level = "Silver 10%" + memberLevel;
            discount = Price * (0.10 + memberDiscount);
            Suggestion = $"Buy more {3000 - Price} to get 15% discount";
        }

        if (Price >= 500) {
            level = "Bronze 5%" + memberLevel;
            discount = Price * (0.05 + memberDiscount);
            Suggestion = $"Buy more {1000 - Price} to get 10% discount";
        } else {
            Suggestion = $"Buy more {500 - Price} to get 5% discount";
        }

        this.Level = level;
        this.Discount = discount;
    }
}