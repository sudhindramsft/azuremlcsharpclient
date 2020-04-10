// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.MachineLearning.Services.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class RunConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the RunConfiguration class.
        /// </summary>
        public RunConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RunConfiguration class.
        /// </summary>
        /// <param name="script">The relative path to the python script file.
        /// The file path is relative to the source_directory passed to submit
        /// run.</param>
        /// <param name="arguments">Command line arguments for the python
        /// script file.</param>
        /// <param name="framework">The supported frameworks are Python,
        /// PySpark, CNTK, TensorFlow, and PyTorch. Use Tensorflow for
        /// AmlCompute clusters, and Python for distributed training jobs.
        /// Possible values include: 'Python', 'PySpark', 'Cntk', 'TensorFlow',
        /// 'PyTorch'</param>
        /// <param name="communicator">The supported communicators are None,
        /// ParameterServer, OpenMpi, and IntelMpi Keep in mind that OpenMpi
        /// requires a custom image with OpenMpi installed.
        /// Use ParameterServer or OpenMpi for AmlCompute clusters. Use
        /// IntelMpi for distributed training jobs. Possible values include:
        /// 'None', 'ParameterServer', 'Gloo', 'Mpi', 'Nccl'</param>
        /// <param name="target">Target refers to compute where the job is
        /// scheduled for execution. The default target is "local" referring to
        /// the local machine.</param>
        /// <param name="dataReferences">All the data sources are made
        /// available to the run during execution based on each
        /// configuration.</param>
        /// <param name="jobName">This is primarily intended for notebooks to
        /// override the default job name.
        /// Defaults to ArgumentVector[0] if not specified.</param>
        /// <param name="maxRunDurationSeconds">Maximum allowed time for the
        /// run. The system will attempt to automatically cancel the run if it
        /// took longer than this value.
        /// MaxRunDurationSeconds=null means infinite duration.</param>
        /// <param name="nodeCount">Number of compute nodes to run the job on.
        /// Only applies to AMLCompute.</param>
        /// <param name="environment">The environment definition, This field
        /// configures the python environment.
        /// It can be configured to use an existing Python environment or
        /// configured to setup a temp environment for the experiment.
        /// The definition is also responsible for setting the required
        /// application dependencies.</param>
        /// <param name="history">This section is used to disable and enable
        /// experiment history logging features.</param>
        /// <param name="spark">When the platform is set to Pyspark, The spark
        /// configuration is used to set the default sparkconf for the
        /// submitted job.</param>
        /// <param name="tensorflow">The attribute is used to configure the
        /// distributed tensorflow parameters.
        /// This attribute takes effect only when the framework is set to
        /// TensorFlow, and the communicator to ParameterServer.
        /// AmlCompute is the only supported compute for this
        /// configuration.</param>
        /// <param name="mpi">The attribute is used to configure the
        /// distributed MPI job parameters.
        /// This attribute takes effect only when the framework is set to
        /// Python, and the communicator to OpenMpi or IntelMpi.
        /// AmlCompute is the only supported compute type for this
        /// configuration.</param>
        /// <param name="hdi">This attribute takes effect only when the target
        /// is set to an Azure HDI compute.
        /// The HDI Configuration is used to set the YARN deployment mode. It
        /// is defaulted to cluster mode.</param>
        public RunConfiguration(string script = default(string), IList<string> arguments = default(IList<string>), Framework? framework = default(Framework?), Communicator? communicator = default(Communicator?), string target = default(string), IDictionary<string, DataReferenceConfiguration> dataReferences = default(IDictionary<string, DataReferenceConfiguration>), string jobName = default(string), long? maxRunDurationSeconds = default(long?), int? nodeCount = default(int?), EnvironmentDefinition environment = default(EnvironmentDefinition), HistoryConfiguration history = default(HistoryConfiguration), SparkConfiguration spark = default(SparkConfiguration), TensorflowConfiguration tensorflow = default(TensorflowConfiguration), MpiConfiguration mpi = default(MpiConfiguration), HdiConfiguration hdi = default(HdiConfiguration))
        {
            Script = script;
            Arguments = arguments;
            Framework = framework;
            Communicator = communicator;
            Target = target;
            DataReferences = dataReferences;
            JobName = jobName;
            MaxRunDurationSeconds = maxRunDurationSeconds;
            NodeCount = nodeCount;
            Environment = environment;
            History = history;
            Spark = spark;
            Tensorflow = tensorflow;
            Mpi = mpi;
            Hdi = hdi;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the relative path to the python script file. The file
        /// path is relative to the source_directory passed to submit run.
        /// </summary>
        [JsonProperty(PropertyName = "script")]
        public string Script { get; set; }

        /// <summary>
        /// Gets or sets command line arguments for the python script file.
        /// </summary>
        [JsonProperty(PropertyName = "arguments")]
        public IList<string> Arguments { get; set; }

        /// <summary>
        /// Gets or sets the supported frameworks are Python, PySpark, CNTK,
        /// TensorFlow, and PyTorch. Use Tensorflow for AmlCompute clusters,
        /// and Python for distributed training jobs. Possible values include:
        /// 'Python', 'PySpark', 'Cntk', 'TensorFlow', 'PyTorch'
        /// </summary>
        [JsonProperty(PropertyName = "framework")]
        public Framework? Framework { get; set; }

        /// <summary>
        /// Gets or sets the supported communicators are None, ParameterServer,
        /// OpenMpi, and IntelMpi Keep in mind that OpenMpi requires a custom
        /// image with OpenMpi installed.
        /// Use ParameterServer or OpenMpi for AmlCompute clusters. Use
        /// IntelMpi for distributed training jobs. Possible values include:
        /// 'None', 'ParameterServer', 'Gloo', 'Mpi', 'Nccl'
        /// </summary>
        [JsonProperty(PropertyName = "communicator")]
        public Communicator? Communicator { get; set; }

        /// <summary>
        /// Gets or sets target refers to compute where the job is scheduled
        /// for execution. The default target is "local" referring to the local
        /// machine.
        /// </summary>
        [JsonProperty(PropertyName = "target")]
        public string Target { get; set; }

        /// <summary>
        /// Gets or sets all the data sources are made available to the run
        /// during execution based on each configuration.
        /// </summary>
        [JsonProperty(PropertyName = "dataReferences")]
        public IDictionary<string, DataReferenceConfiguration> DataReferences { get; set; }

        /// <summary>
        /// Gets or sets this is primarily intended for notebooks to override
        /// the default job name.
        /// Defaults to ArgumentVector[0] if not specified.
        /// </summary>
        [JsonProperty(PropertyName = "jobName")]
        public string JobName { get; set; }

        /// <summary>
        /// Gets or sets maximum allowed time for the run. The system will
        /// attempt to automatically cancel the run if it took longer than this
        /// value.
        /// MaxRunDurationSeconds=null means infinite duration.
        /// </summary>
        [JsonProperty(PropertyName = "maxRunDurationSeconds")]
        public long? MaxRunDurationSeconds { get; set; }

        /// <summary>
        /// Gets or sets number of compute nodes to run the job on. Only
        /// applies to AMLCompute.
        /// </summary>
        [JsonProperty(PropertyName = "nodeCount")]
        public int? NodeCount { get; set; }

        /// <summary>
        /// Gets or sets the environment definition, This field configures the
        /// python environment.
        /// It can be configured to use an existing Python environment or
        /// configured to setup a temp environment for the experiment.
        /// The definition is also responsible for setting the required
        /// application dependencies.
        /// </summary>
        [JsonProperty(PropertyName = "environment")]
        public EnvironmentDefinition Environment { get; set; }

        /// <summary>
        /// Gets or sets this section is used to disable and enable experiment
        /// history logging features.
        /// </summary>
        [JsonProperty(PropertyName = "history")]
        public HistoryConfiguration History { get; set; }

        /// <summary>
        /// Gets or sets when the platform is set to Pyspark, The spark
        /// configuration is used to set the default sparkconf for the
        /// submitted job.
        /// </summary>
        [JsonProperty(PropertyName = "spark")]
        public SparkConfiguration Spark { get; set; }

        /// <summary>
        /// Gets or sets the attribute is used to configure the distributed
        /// tensorflow parameters.
        /// This attribute takes effect only when the framework is set to
        /// TensorFlow, and the communicator to ParameterServer.
        /// AmlCompute is the only supported compute for this configuration.
        /// </summary>
        [JsonProperty(PropertyName = "tensorflow")]
        public TensorflowConfiguration Tensorflow { get; set; }

        /// <summary>
        /// Gets or sets the attribute is used to configure the distributed MPI
        /// job parameters.
        /// This attribute takes effect only when the framework is set to
        /// Python, and the communicator to OpenMpi or IntelMpi.
        /// AmlCompute is the only supported compute type for this
        /// configuration.
        /// </summary>
        [JsonProperty(PropertyName = "mpi")]
        public MpiConfiguration Mpi { get; set; }

        /// <summary>
        /// Gets or sets this attribute takes effect only when the target is
        /// set to an Azure HDI compute.
        /// The HDI Configuration is used to set the YARN deployment mode. It
        /// is defaulted to cluster mode.
        /// </summary>
        [JsonProperty(PropertyName = "hdi")]
        public HdiConfiguration Hdi { get; set; }

    }
}
