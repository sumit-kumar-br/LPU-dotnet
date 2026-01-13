namespace FactoryRobotHazardAnalyzer
{
    public class RobotHazardAuditor
    {
        public double CalculateHazardRisk(double armPrecision, int workerDensity, string machinaryState)
        {
            if(armPrecision < 0.0 || armPrecision > 1.0)
            {
                throw new RobotSafetyException("Error: Arm Precision must be 0.0-1.0");
            }
            if(workerDensity < 1 || workerDensity > 20)
            {
                throw new RobotSafetyException("Error: Worker density must be 1-20");
            }
            if(!machinaryState.Equals("Worn") &&
               !machinaryState.Equals("Faulty") &&
               !machinaryState.Equals("Critical"))
            {
                throw new RobotSafetyException("Error: Unsupported machinery type");
            }
            double hazardRisk;
            double machineRiskFactor;
            if (machinaryState.Equals("Worn"))
            {
                machineRiskFactor = 1.3;
            }
            else if (machinaryState.Equals("Faulty"))
            {
                machineRiskFactor = 2.0;
            }
            else
            {
                machineRiskFactor = 3.0;
            }
            hazardRisk = ((1.0-armPrecision)*15.0)+(workerDensity*machineRiskFactor);
            return hazardRisk;
        }
    }
}