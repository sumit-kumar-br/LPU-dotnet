// Scenario 3: Hospital Patient Management System
// Problem: Create a type-safe medical records system with different patient types and treatments.
// csharp
using System.Diagnostics;

public interface IPatient
{
    int PatientId { get; }
    string Name { get; }
    DateTime DateOfBirth { get; }
    BloodType BloodType { get; }
}

public enum BloodType { A, B, AB, O }
public enum Condition { Stable, Critical, Recovering }

// 1. Generic patient queue with priority
public class PriorityQueue<T> where T : IPatient
{
    private SortedDictionary<int, Queue<T>> _queues = new();
    
    // TODO: Enqueue patient with priority (1=highest, 5=lowest)
    public void Enqueue(T patient, int priority)
    {
        // Validate priority range
        // Create queue if doesn't exist for priority
        if(priority < 1 || priority > 5)
        {
            throw new ArgumentOutOfRangeException("Priority must be between 1 and 5");
        }
        if (!_queues.ContainsKey(priority))
        {
            _queues[priority] = new Queue<T>();
        }
        _queues[priority].Enqueue(patient);
    }
    
    // TODO: Dequeue highest priority patient
    public T Dequeue()
    {
        // Return patient from highest non-empty priority
        // Throw if empty
        foreach(var queue in _queues)
        {
            if(queue.Value.Count > 0)
            {
                return queue.Value.Dequeue();
            }
        }
        throw new InvalidOperationException("Queue is empty");
    }
    
    // TODO: Peek without removing
    public T Peek()
    {
        // Look at next patient
        foreach(var queue in _queues)
        {
            if(queue.Value.Count > 0)
            {
                return queue.Value.Peek();
            }
        }
        throw new InvalidOperationException("Queue is empty");
    }
    
    // TODO: Get count by priority
    public int GetCountByPriority(int priority)
    {
        // Return count for specific priority
        if (_queues.ContainsKey(priority))
        {
            return _queues[priority].Count;
        }
        return 0;
    }
}

// 2. Generic medical record
public class MedicalRecord<T> where T : IPatient
{
    private T _patient;
    private List<string> _diagnoses = new();
    private Dictionary<DateTime, string> _treatments = new();
    
    // TODO: Add diagnosis with date
    public void AddDiagnosis(string diagnosis, DateTime date)
    {
        // Add to diagnoses list
        _diagnoses.Add(diagnosis);
    }
    
    // TODO: Add treatment
    public void AddTreatment(string treatment, DateTime date)
    {
        // Add to treatments dictionary
        _treatments[date] = treatment;
    }
    
    // TODO: Get treatment history
    public IEnumerable<KeyValuePair<DateTime, string>> GetTreatmentHistory()
    {
        // Return sorted by date
        return _treatments.OrderBy(t => t.Key);
    }
}

// 3. Specialized patient types
public class PediatricPatient : IPatient
{
    public int PatientId { get; set; }
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public BloodType BloodType { get; set; }
    public string GuardianName { get; set; }
    public double Weight { get; set; } // in kg
}

public class GeriatricPatient : IPatient
{
    public int PatientId { get; set; }
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public BloodType BloodType { get; set; }
    public List<string> ChronicConditions { get; } = new();
    public int MobilityScore { get; set; } // 1-10
}

// 4. Generic medication system
public class MedicationSystem<T> where T : IPatient
{
    private Dictionary<T, List<(string medication, DateTime time)>> _medications = new();
    
    // TODO: Prescribe medication with dosage validation
    public void PrescribeMedication(T patient, string medication, 
        Func<T, bool> dosageValidator)
    {
        // Check if dosage is valid for patient type
        // Pediatric: weight-based validation
        // Geriatric: kidney function consideration
        if (!dosageValidator(patient))
        {
            throw new InvalidOperationException("Dosage verification failed!");
        }
        if (!_medications.ContainsKey(patient))
        {
            _medications[patient] = new List<(string, DateTime)>();
        }
        _medications[patient].Add((medication, DateTime.Now));
    }
    
    // TODO: Check for drug interactions
    public bool CheckInteractions(T patient, string newMedication)
    {
        // Return true if interaction with existing medications
        if (!_medications.ContainsKey(patient))
        {
            return false;
        }
        var existing = _medications[patient].Select(m => m.medication);
        return existing.Any(m => m == newMedication);
    }
}

// 5. TEST SCENARIO: Simulate hospital workflow
// a) Create 2 PediatricPatient and 2 GeriatricPatient
// b) Add them to priority queue with different priorities
// c) Create medical records with diagnoses/treatments
// d) Prescribe medications with type-specific validation
// e) Demonstrate:
//    - Priority-based patient processing
//    - Age-specific medication validation
//    - Treatment history retrieval
//    - Drug interaction checking
