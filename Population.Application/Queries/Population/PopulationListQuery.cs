using System;
using System.Linq;
using System.Collections.Generic;
using Population.Infrastructure.Repository;
using Population.Application.Infrastructure.CQExecutionResult;

namespace Population.Application.Infrastructure.QueryInfrastructure.Queries.Population
{
    public class PopulationListQuery : Query<PopulationListQueryResult>
    {
        #region Repository

        public IRepository<Domain.Population.Population> _populationRepository = new Repository<Domain.Population.Population>();

        #endregion

        #region Execute

        public override QueryExecutionResult<PopulationListQueryResult> Execute()
        {
            try
            {
                var result = new PopulationListQueryResult();
                var populations = _populationRepository.GetAll().AsEnumerable();

                result.Listing = populations.Select(population => new PopulationListQueryResult
                {
                    Id = population.Id,
                    IdentificationNumber = population.IdentificationNumber,
                    CertificationIdentification = population.CertificationIdentification,
                    FirstName = population.FirstName,
                    LastName = population.LastName,
                    FatherName = population.FatherName,
                    DMONAC = population.DMONAC,
                    Sex = population.Sex,
                    BirthDate = population.BirthDate,
                    RegisterDate = population.RegisterDate
                }).ToList();

                return Ok(result);
            }
            catch (Exception exception)
            {
                return Fail(exception);
            }
        }

        #endregion
    }

    public class PopulationListQueryResult
    {
        public List<PopulationListQueryResult> Listing = new List<PopulationListQueryResult>();

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
    }
}
