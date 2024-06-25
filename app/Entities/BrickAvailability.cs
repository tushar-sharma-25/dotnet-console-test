namespace app.Entities;
public class BrickAvailability
{
    public int Id {get;set;}
    public int AvailableAmount {get; set;}

    public decimal PriceEur {get;set;}
    public int BrickId {get;set;}
    public int  VendorId {get;set;}

}