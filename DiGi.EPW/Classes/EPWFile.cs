using DiGi.Core.Classes;
using DiGi.EPW.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.EPW.Classes
{
    /// <summary>
    /// Represents an EnergyPlus Weather (EPW) file and its associated data.
    /// </summary>
    public class EPWFile : SerializableObject, IEPWSerializableObject
    {
        [JsonInclude, JsonPropertyName(nameof(Location))]
        private readonly Location? location = null;

        [JsonInclude, JsonPropertyName(nameof(DesignConditions))]
        private readonly DesignConditions? designConditions = null;

        [JsonInclude, JsonPropertyName(nameof(TypicalExtremePeriods))]
        private readonly IList<TypicalExtremePeriod>? typicalExtremePeriods = null;

        [JsonInclude, JsonPropertyName(nameof(GroundTemperatures))]
        private readonly IList<GroundTemperature>? groundTemperatures = null;

        [JsonInclude, JsonPropertyName(nameof(HolidaysDaylightSaving))]
        private readonly HolidaysDaylightSaving? holidaysDaylightSaving = null;

        [JsonInclude, JsonPropertyName(nameof(Comments1))]
        private readonly string? comments1 = null;

        [JsonInclude, JsonPropertyName(nameof(Comments2))]
        private readonly string? comments2 = null;

        [JsonInclude, JsonPropertyName(nameof(DataPeriods))]
        private readonly IList<DataPeriod>? dataPeriods = null;

        [JsonInclude, JsonPropertyName(nameof(DataRecords))]
        private readonly IList<DataRecord>? dataRecords = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="EPWFile"/> class.
        /// </summary>
        /// <param name="location">The location associated with the EPW file.</param>
        /// <param name="designConditions">The design conditions header record.</param>
        /// <param name="typicalExtremePeriods">The typical/extreme periods header record.</param>
        /// <param name="groundTemperatures">The ground temperatures header record.</param>
        /// <param name="holidaysDaylightSaving">The holidays/daylight saving header record.</param>
        /// <param name="comments1">The first comments header record.</param>
        /// <param name="comments2">The second comments header record.</param>
        /// <param name="dataPeriods">The data periods header record.</param>
        /// <param name="dataRecords">The hourly weather data records.</param>
        public EPWFile(Location? location, DesignConditions? designConditions = null, IList<TypicalExtremePeriod>? typicalExtremePeriods = null, IList<GroundTemperature>? groundTemperatures = null, HolidaysDaylightSaving? holidaysDaylightSaving = null, string? comments1 = null, string? comments2 = null, IList<DataPeriod>? dataPeriods = null, IList<DataRecord>? dataRecords = null)
        {
            this.location = location;
            this.designConditions = designConditions;
            this.typicalExtremePeriods = typicalExtremePeriods;
            this.groundTemperatures = groundTemperatures;
            this.holidaysDaylightSaving = holidaysDaylightSaving;
            this.comments1 = comments1;
            this.comments2 = comments2;
            this.dataPeriods = dataPeriods;
            this.dataRecords = dataRecords;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EPWFile"/> class by copying an existing instance.
        /// </summary>
        /// <param name="ePWFile">The source EPW file to copy from.</param>
        public EPWFile(EPWFile? ePWFile)
            : base(ePWFile)
        {
            if (ePWFile != null)
            {
                location = Core.Query.Clone(ePWFile.location);
                designConditions = Core.Query.Clone(ePWFile.designConditions);
                holidaysDaylightSaving = Core.Query.Clone(ePWFile.holidaysDaylightSaving);
                comments1 = ePWFile.comments1;
                comments2 = ePWFile.comments2;

                if (ePWFile.typicalExtremePeriods != null)
                {
                    typicalExtremePeriods = [];
                    foreach (TypicalExtremePeriod typicalExtremePeriod in ePWFile.typicalExtremePeriods)
                    {
                        if (Core.Query.Clone(typicalExtremePeriod) is TypicalExtremePeriod typicalExtremePeriod_Temp)
                        {
                            typicalExtremePeriods.Add(typicalExtremePeriod_Temp);
                        }
                    }
                }

                if (ePWFile.groundTemperatures != null)
                {
                    groundTemperatures = [];
                    foreach (GroundTemperature groundTemperature in ePWFile.groundTemperatures)
                    {
                        if (Core.Query.Clone(groundTemperature) is GroundTemperature groundTemperature_Temp)
                        {
                            groundTemperatures.Add(groundTemperature_Temp);
                        }
                    }
                }

                if (ePWFile.dataPeriods != null)
                {
                    dataPeriods = [];
                    foreach (DataPeriod dataPeriod in ePWFile.dataPeriods)
                    {
                        if (Core.Query.Clone(dataPeriod) is DataPeriod dataPeriod_Temp)
                        {
                            dataPeriods.Add(dataPeriod_Temp);
                        }
                    }
                }

                if (ePWFile.dataRecords != null)
                {
                    dataRecords = [];
                    foreach (DataRecord dataRecord in ePWFile.dataRecords)
                    {
                        if (Core.Query.Clone(dataRecord) is DataRecord dataRecord_Temp)
                        {
                            dataRecords.Add(dataRecord_Temp);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EPWFile"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing EPW file data.</param>
        public EPWFile(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the location information associated with this EPW file.
        /// </summary>
        [JsonIgnore]
        public Location? Location
        {
            get
            {
                return location;
            }
        }

        /// <summary>
        /// Gets the design conditions header record.
        /// </summary>
        [JsonIgnore]
        public DesignConditions? DesignConditions
        {
            get
            {
                return designConditions;
            }
        }

        /// <summary>
        /// Gets the typical/extreme periods header record.
        /// </summary>
        [JsonIgnore]
        public IList<TypicalExtremePeriod>? TypicalExtremePeriods
        {
            get
            {
                return typicalExtremePeriods;
            }
        }

        /// <summary>
        /// Gets the ground temperatures header record.
        /// </summary>
        [JsonIgnore]
        public IList<GroundTemperature>? GroundTemperatures
        {
            get
            {
                return groundTemperatures;
            }
        }

        /// <summary>
        /// Gets the holidays/daylight saving header record.
        /// </summary>
        [JsonIgnore]
        public HolidaysDaylightSaving? HolidaysDaylightSaving
        {
            get
            {
                return holidaysDaylightSaving;
            }
        }

        /// <summary>
        /// Gets the first comments header record.
        /// </summary>
        [JsonIgnore]
        public string? Comments1
        {
            get
            {
                return comments1;
            }
        }

        /// <summary>
        /// Gets the second comments header record.
        /// </summary>
        [JsonIgnore]
        public string? Comments2
        {
            get
            {
                return comments2;
            }
        }

        /// <summary>
        /// Gets the data periods header record.
        /// </summary>
        [JsonIgnore]
        public IList<DataPeriod>? DataPeriods
        {
            get
            {
                return dataPeriods;
            }
        }

        /// <summary>
        /// Gets the hourly weather data records.
        /// </summary>
        [JsonIgnore]
        public IList<DataRecord>? DataRecords
        {
            get
            {
                return dataRecords;
            }
        }
    }
}
