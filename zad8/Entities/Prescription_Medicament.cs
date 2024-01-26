namespace zad8;

public class Prescription_Medicament
{
    public int IdMedicament { get; set; }
    
    public int IdPrescription { get; set; }
    
    public int Dose { get; set; }
    
    public string Details { get; set; } = null!;
    
    public virtual Medicament Medicament { get; set; } = null!;
    
    public virtual Prescription Prescription { get; set; } = null!;
}