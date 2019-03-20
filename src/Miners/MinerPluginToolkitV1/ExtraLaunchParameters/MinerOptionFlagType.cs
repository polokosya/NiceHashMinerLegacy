﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MinerPluginToolkitV1.ExtraLaunchParameters
{
    /// <summary>
    /// Describes the flag option. The parser uses these enums to properly parse and merge miner options.
    /// </summary>
    public enum MinerOptionType
    {
        /// <summary>
        /// FlagIsParameter indicates that option has no parameter.
        /// </summary>
        /// <example>--help</example>
        /// <example>--disable-colors</example>
        OptionIsParameter,

        /// <summary>
        /// OptionWithSingleParameter indicates that option takes only 1 parameter.
        /// If multiple devices use the same parameter it will use only the first one encountered.
        /// </summary>
        /// <example>--algo ALGORITHM</example>
        OptionWithSingleParameter,

        /// <summary>
        /// OptionWithMultipleParamters indicates that option takes one or more parameters.
        /// When there is more than one parameter there is a set delimiter
        /// </summary>
        /// comma separated intensity values
        /// <example>--intensity 20,-1,21</example>
        OptionWithMultipleParamters,

        /// <summary>
        /// OptionWithDuplicateMultipleParamters indicates that option takes one or more parameters but with repeated flag.
        /// </summary>
        /// Intensity 
        /// <example>--intensity 20 --intensity -1 --intensity 21</example>
        OptionWithDuplicateMultipleParamters
    }
}