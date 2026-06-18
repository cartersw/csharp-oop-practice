using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpIntermediate
{
    internal class OtherDbMigrator
    {
        private readonly ILogger _logger;
        public OtherDbMigrator(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {

            _logger.LogInfo("Migrating started at " + DateTime.Now);


            _logger.LogInfo("Migrating completed at " + DateTime.Now);
        }
            
    }
}
