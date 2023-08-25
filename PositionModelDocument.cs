using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using TradingToolbox.System.Data.NoSql.MongoDB.Models;

namespace TradingToolbox.Trading.Modeler.Data.NoSql.MongoDB.Models
{
    /// <summary>
    /// Position model document implementation.
    /// </summary>
    [BsonCollection("position-models")]
    public class PositionModelDocument : Document
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="PositionModelDocument"/> class.
        /// </summary>
        public PositionModelDocument()
        {
        } 
        #endregion

        /// <summary>
        /// Gets or sets the name of the position model.
        /// </summary>
        /// <value>
        /// The name of the position model.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the initial position value.
        /// </summary>
        /// <value>
        /// The initial position value.
        /// </value>
        [BsonRepresentation(BsonType.Decimal128)]
        public Decimal InitialValue { get; set; }

        /// <summary>
        /// Gets or sets the price per share.
        /// </summary>
        /// <value>
        /// The price per share.
        /// </value>
        [BsonRepresentation(BsonType.Decimal128)]
        public Decimal PricePerShare { get; set; }

        /// <summary>
        /// Gets or sets the average number of positions per day.
        /// </summary>
        /// <value>
        /// The average number of positions per day.
        /// </value>
        public Byte AverageNumberOfPositionsPerDay { get; set; }

        /// <summary>
        /// Gets or sets the average number of lots per position.
        /// </summary>
        /// <value>
        /// The average number of lots per position.
        /// </value>
        public Byte AverageNumberOfLotsPerPosition { get; set; }

        /// <summary>
        /// Gets or sets the average number of trading days per week.
        /// </summary>
        /// <value>
        /// The average number of trading days per week.
        /// </value>
        public Byte AverageNumberOfTradingDaysPerWeek { get; set; }

        /// <summary>
        /// Gets or sets the estimated success rate.
        /// </summary>
        /// <value>
        /// The estimated success rate.
        /// </value>
        [BsonRepresentation(BsonType.Decimal128)]
        public Decimal EstimatedSuccessRate { get; set; }

        /// <summary>
        /// Gets or sets the target gain.
        /// </summary>
        /// <value>
        /// The target gain.
        /// </value>
        [BsonRepresentation(BsonType.Decimal128)]
        public Decimal TargetGain { get; set; }

        /// <summary>
        /// Gets or sets the federal tax rate.
        /// </summary>
        /// <value>
        /// The federal tax rate.
        /// </value>
        [BsonRepresentation(BsonType.Decimal128)]
        public Decimal FederalTaxRate { get; set; }

        /// <summary>
        /// Gets or sets the state tax rate.
        /// </summary>
        /// <value>
        /// The state tax rate.
        /// </value>
        [BsonRepresentation(BsonType.Decimal128)]
        public Decimal StateTaxRate { get; set; }

        /// <summary>
        /// Gets or sets the expenses.
        /// </summary>
        /// <value>
        /// The expenses.
        /// </value>
        [BsonRepresentation(BsonType.Decimal128)]
        public Decimal Expenses { get; set; }

        /// <summary>
        /// Gets or sets the estimated fee per transaction.
        /// </summary>
        /// <value>
        /// The estimated fee per transaction.
        /// </value>
        [BsonRepresentation(BsonType.Decimal128)]
        public Decimal EstimatedFeePerTransaction { get; set; }

        /// <summary>
        /// Gets or sets the list position.
        /// </summary>
        /// <value>
        /// The list position.
        /// </value>
        [BsonRepresentation(BsonType.Int64)]
        public long ListPosition { get; set; }
    }
}
