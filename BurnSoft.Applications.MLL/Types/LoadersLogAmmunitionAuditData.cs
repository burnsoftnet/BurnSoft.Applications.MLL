using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurnSoft.Applications.MLL.Types
{
    /// <summary>
    /// Class LoadersLogAmmunitionAuditData.is the list container 
    /// for the Loaders_Log_Ammunition_Audit Table
    /// </summary>
    public class LoadersLogAmmunitionAuditData
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public long Id { get; set; }
        /// <summary>
        /// Gets or sets the configuration identifier. for the CFID column
        /// </summary>
        /// <value>The configuration identifier.</value>
        public long ConfigId { get; set; }
        /// <summary>
        /// Gets or sets the date created. for the dtc column
        /// </summary>
        /// <value>The date created.</value>
        public string DateCreated { get; set; }
        /// <summary>
        /// Gets or sets the qty.
        /// </summary>
        /// <value>The qty.</value>
        public int Qty { get; set; }
        /// <summary>
        /// Gets or sets the estimated cost to make total. for the ec column
        /// </summary>
        /// <value>The estimated cost to make total.</value>
        public double EstimatedCostToMakeTotal { get; set; }
        /// <summary>
        /// Gets or sets the estimated cost to male per round. for the ecpr column
        /// </summary>
        /// <value>The estimated cost to male per round.</value>
        public double EstimatedCostToMalePerRound { get; set; }
        /// <summary>
        /// Gets or sets the last synchronize for the sync_lastupdate column
        /// </summary>
        /// <value>The last synchronize.</value>
        public string LastSync { get; set; }
    }
}
