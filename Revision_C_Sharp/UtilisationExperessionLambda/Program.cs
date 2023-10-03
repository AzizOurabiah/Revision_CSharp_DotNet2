
namespace UtilisationExperessionLambda
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public bool IsDirty { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ecrire une liste des Customers
            List<Customer> listCust = new List<Customer>() {
                                                            new Customer()
                                                                { CustomerId = 1, FirstName = "Aziz", LastName = "Aziz", EmailAddress = "Aziz", IsDirty = false },
                                                            new Customer()
                                                                { CustomerId = 2, FirstName = "Aziz", LastName = "Aziz", EmailAddress = "Aziz", IsDirty = false }};
            listCust.Add(
                new Customer() { CustomerId = 3, FirstName = "Aziz", LastName = "Aziz", EmailAddress = "Aziz", IsDirty = false }
                );

            Customer foundCustomer = null;

            foreach (var cust in listCust)
            {
                if (cust.CustomerId == 1)
                    foundCustomer = cust;
            }

            Console.WriteLine(foundCustomer.CustomerId);


            //Utilisation d'expression Lambda
            var foundCustomer1 = listCust.FirstOrDefault(x => x.CustomerId == 1);

            //Utilisation de Query
            var query = from c in listCust where c.CustomerId == 1 select c;

            Customer foundCustomer2 = null;

            if (query.Count() > 0)
                foundCustomer2 = query.ToList()[0];
        }
    }
}