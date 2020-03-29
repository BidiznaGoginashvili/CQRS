using System;
using Population.Infrastructure.Repository;
using Population.Application.Infrastructure.CQExecutionResult;
using Population.Application.Infrastructure.CommandInfrastructure;

namespace Population.Application.Infrastructure.Commands.Population
{
    public class CreatePopulationCommand : Command
    {
        #region Repository

        public IRepository<Domain.Population.Population> _populationRepository = new Repository<Domain.Population.Population>();

        #endregion

        #region Fields 

        public int Id { get; set; }
        public string IdentificationNumber { get; set; }
        public string CertificationIdentification { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string DMONAC { get; set; }
        public string Street { get; set; }
        public string Region { get; set; }
        public Int16? Sex { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? RegisterDate { get; set; }

        #endregion

        #region Execute

        public override CommandExecutionResult Execute()
        {
            try
            {
                var population = new Domain.Population.Population(Id, IdentificationNumber,
                CertificationIdentification,
                FirstName, LastName, FatherName, DMONAC,
                Street, Region, Sex, BirthDate,
                RegisterDate);

                _populationRepository.Insert(population);

                return Ok(population);
            }
            catch(Exception exception)
            {
                return Fail(exception);
            }
        }

        #endregion
    }
}
