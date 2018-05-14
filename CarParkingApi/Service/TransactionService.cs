using CarParking.Entities;
using CarParking.Helpers;

namespace CarParkingApi.Service
{
    public class TransactionService
    {
        private readonly Parking parking;

        public TransactionService()
        {
            parking = Parking.Instance;
        }

        public string GetLogFile()
        {
            var logFile = FileHelper.ReadLogFile();
            return logFile;
        }

        public double GetParkingIncomeForPastMinute()
        {
            return parking.GetParkingIncomeForPastMinute();
        }

        public double GetParkingIncomeForPastMinute(int id)
        {
            return parking.GetParkingIncomeForPastMinute(id);
        }

        public void ReplenishAccountById(int id, double amount)
        {
            parking.ReplenishCarBalance(id, amount);
        }
    }
}