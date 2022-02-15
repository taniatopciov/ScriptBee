﻿using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using ScriptBeePlugin;

namespace ScriptBeeTests.Scripts.ScriptSampleGenerators
{
    public class TestModelLoader : IModelLoader
    {
        public Task<Dictionary<string, Dictionary<string, ScriptBeeModel>>> LoadModel(List<Stream> fileStreams,
            Dictionary<string, object> configuration = null)
        {
            return new Task<Dictionary<string, Dictionary<string, ScriptBeeModel>>>(() =>
                new Dictionary<string, Dictionary<string, ScriptBeeModel>>());
        }

        public string GetName()
        {
            return "";
        }
    }
}