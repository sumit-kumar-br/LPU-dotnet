using System;
using System.ComponentModel.Design.Serialization;

namespace Week1Assignment
{
    public class Customer1
    {
        public int CustId { get; set; }
        public string CustName { get; set; }
        public string CustAddress { get; set; }
        public string CustMob { get; set; }
        public string CustStatus { get; set; }
        public Customer1() {  }
        public Customer1(int custId,string custName,string custAddress,string custMob)
        {
            this.CustId = custId;
            this.CustName = custName;
            this.CustAddress = custAddress;
            this.CustMob = custMob;
        }
    }
    public class Agency
    {
        public string AgencyName { get; set; }
        public string AgencyAdd { get; set; }
        public string AgencyCNo { get; set; }
        public Agency() {   }

        public Agency(string agencyName, string agencyAdd, string agencyCNo)
        {
            this.AgencyName = agencyName;
            this.AgencyAdd = agencyAdd;
            this.AgencyCNo = agencyCNo;
        }
        public Customer1 VerifyCustomer(Customer1 customer)
        {
            if(customer.CustId % 2 == 0)
            {
                customer.CustStatus = "Green";
            }
            else
            {
                customer.CustStatus = "Red";
            }
            return customer;
        }
    }
}