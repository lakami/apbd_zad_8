namespace zad8.Models;

public class GetPrescriptionDTO
{
    public Patient Patient { get; set; }

    public IEnumerable<Medicament> Medicaments { get; set; }
    
    public int IdPrescription { get; set; }
    
    public DateTime Date { get; set; }
    
    public DateTime DueDate { get; set; }
    
    public GetDoctorDTO Doctor { get; set; } = null!;
    
}

public class Patient
{
    public int IdPatient { get; set; }
    
    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateTime Birthdate { get; set; }
    
}

public class Medicament
{
    public int IdMedicament { get; set; }
    
    public string Name { get; set; } = null!;
    
    public string Description { get; set; } = null!;
    
    public string Type { get; set; } = null!;
    
    public int Dose { get; set; }
    
    public string Details { get; set; } = null!;
    
}