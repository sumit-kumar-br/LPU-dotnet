// Model Class
    class Vessel
    {
        public string VesselId { get; set; } = "";
        public string VesselName { get; set; } = "";
        public double AverageSpeed { get; set; }
        public string VesselType { get; set; } = "";

        // No-argument constructor
        public Vessel()
        { }

        // Parameterized constructor
        public Vessel(string vesselId, string vesselName, double averageSpeed, string vesselType)
        {
            VesselId = vesselId;
            VesselName = vesselName;
            AverageSpeed = averageSpeed;
            VesselType = vesselType;
        }
    }

    // Utility Class
    class VesselUtil
    {
        private List<Vessel> vesselList = new List<Vessel>();

        public List<Vessel> VesselList
        {
            get { return vesselList; }
            set { vesselList = value; }
        }

        // Requirement 1
        public void AddVesselPerformance(Vessel vessel)
        {
            vesselList.Add(vessel);
        }

        // Requirement 2
        public Vessel GetVesselById(string vesselId)
        {
            return vesselList.FirstOrDefault(s => s.VesselId == vesselId);
        }

        // Requirement 3
        public List<Vessel> GetHighPerformanceVessels()
        {
            if(vesselList.Count() == 0) 
            {
                return new List<Vessel>();
            }

            double maxspeed = vesselList.Max(s => s.AverageSpeed);

            return vesselList.Where(s => s.AverageSpeed == maxspeed).ToList();
        }
    }

    // Main Class
    public class Solution
    {
        static void Main(string[] args)
        {
            VesselUtil vesselUtil = new VesselUtil();

            // Hardcoded data (Sample Input)
            vesselUtil.AddVesselPerformance(new Vessel("V001", "Sea King", 25.5, "Cargo"));
            vesselUtil.AddVesselPerformance(new Vessel("V002", "Ocean Star", 18.0, "Tanker"));
            vesselUtil.AddVesselPerformance(new Vessel("V003", "Wave Rider", 22.3, "Cruise"));

            string searchVesselId = "V001";

            // Requirement 2 Output
            Vessel result = vesselUtil.GetVesselById(searchVesselId);
            if (result != null)
            {
                Console.WriteLine(
                    $"{result.VesselId} | {result.VesselName} | {result.VesselType} | {result.AverageSpeed} knots"
                );
            }

            // Requirement 3 Output
            Console.WriteLine("High performance vessels are");

            List<Vessel> highPerformanceVessels = vesselUtil.GetHighPerformanceVessels();
            foreach (Vessel vessel in highPerformanceVessels)
            {
                Console.WriteLine(
                    $"{vessel.VesselId} | {vessel.VesselName} | {vessel.VesselType} | {vessel.AverageSpeed} knots"
                );
            }
        }
    }