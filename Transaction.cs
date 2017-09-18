public class Transaction {
  // Declare the variables of the Transaction
  public string id ( get; set; );
  public byte addressFrom ( get; set; );
  public byte addressTo ( get; set; );
  public string quantity ( get; set; );
  public string amount ( get; set; );
  public string date ( get; set; );
  public string timestamp ( get; set; );

  //Declare the methods of the Transaction
  public string PayTax() {
    return quantity * amount * 5%;
  }
}

// Construct a new Transaction object named sale using the constructor keyword new and the Transaction class
Transaction sale = new Transaction();
sale.id = "WE123MJ";
sale.addressFrom = "hexstring1234567a";
sale.addressTo = "hexstring1234567b";
sale.quantity = "1";
sale.amount = "200";
date = "122317";
timestamp = "1235679";

// Call the PayTax method of the Transaction class
string tax = sale.PayTax();

public class Purchase : Transaction {
  public decimal Calculate() {
    quantity * amount + tax;
  }
}