﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace RNASeqAnalysisWrappers
{
    public class CufflinksWrapper
    {
        public void assemble_transcripts()
        {

        }

        public void install()
        {
            WrapperUtility.RunBashCommand("sudo", "apt-get install cufflinks");
        }
    }
}
