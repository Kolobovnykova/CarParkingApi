﻿using System;
using CarParking.Interfaces;

namespace CarParking.Entities
{
    public class Transaction : ITransaction
    {
        public DateTime TransactionTime { get; }
        public int CarId { get; }
        public double Withdrawal { get; }

        public Transaction(DateTime transactionTime, int carId, double withdrawal)
        {
            TransactionTime = transactionTime;
            CarId = carId;
            Withdrawal = withdrawal;
        }

        public override string ToString()
        {
            return $"{TransactionTime}, Car Id: {CarId}, withdrew: {Withdrawal}";
        }
    }
}