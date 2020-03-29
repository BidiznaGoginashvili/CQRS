using Microsoft.AspNetCore.Mvc;
using Population.Application.Infrastructure.Commands.Population;
using Population.Application.Infrastructure.CommandInfrastructure;
using Population.Application.Infrastructure.QueryInfrastructure;
using Population.Application.Infrastructure.QueryInfrastructure.Queries.Population;

namespace Population.Controllers.Population
{
    public class PopulationController : Controller
    {
        #region Fields

        private readonly CommandExecutor _commandExecutor;
        private readonly QueryExecutor _queryExecutor;

        #endregion

        #region Ctor

        public PopulationController(CommandExecutor commandExecutor, QueryExecutor queryExecutor)
        {
            _commandExecutor = commandExecutor;
            _queryExecutor = queryExecutor;
        }

        #endregion

        #region Methods

        public IActionResult CreatePopulation()
        {
            var model = new CreatePopulationCommand();

            return View(model);
        }

        [HttpPost]
        public IActionResult CreatePopulation(CreatePopulationCommand command)
        {
            var createPopulationResult = _commandExecutor.Execute(command);

            return RedirectToAction("PopulationListing");
        }

        public IActionResult PopulationListing(PopulationListQuery query)
        {
            var listing = _queryExecutor.Execute<PopulationListQuery, PopulationListQueryResult>(query);

            return View(listing);
        }

        #endregion
    }
}