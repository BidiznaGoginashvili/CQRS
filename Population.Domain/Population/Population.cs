using System;

namespace Population.Domain.Population
{
    public class Population
    {
        public Population(int id,string identificationNumber, string certificationIdentification,
            string firstName,string lastName, string fatherName, string dmonac, string street, string region,
            Int16? sex, DateTime? birthDate, DateTime? registerDate)
        {
            Id = id;
            IdentificationNumber = identificationNumber;
            CertificationIdentification = certificationIdentification;
            FirstName = firstName;
            FatherName = fatherName;
            DMONAC = dmonac;
            Street = street;
            Region = region;
            Sex = sex;
            BirthDate = birthDate;
            RegisterDate = registerDate;
        }

        public int Id { get; private set; }
        public string IdentificationNumber { get; private set; }
        public string CertificationIdentification { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; set; }
        public string FatherName { get; private set; }
        public string DMONAC { get; private set; }
        public string Street { get; private set; }
        public string Region { get; private set; }
        public Int16? Sex { get; private set; }
        public DateTime? BirthDate { get; private set; }
        public DateTime? RegisterDate { get; private set; }
    }
}
