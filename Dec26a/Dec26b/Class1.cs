namespace Dec26b
{
    public class Product
    {
        #region Properties
        //Auto implicit properties
        public int ProdID { get; set; }
        public string Name { get; set; }
        protected string Ingridients { get; set; }
        private int MFCost;
        internal string BatchNo { get; set; }
        protected internal string LotNo { get; set; }
        #endregion
        
        
    }
}
