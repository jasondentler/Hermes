﻿using System;
using TellagoStudios.Hermes.Logging.Model;

namespace TellagoStudios.Hermes.Logging
{
    public static class LogExtensions
    {
        static public Facade.LogEntry ToFacade(this LogEntry from)
        {
            if (from == null || !from.Id.HasValue) return null;

            var entry  = new Facade.LogEntry
            {
                Id = from.Id.Value.ToFacade(),
                UtcTs = from.UtcTs,
                Message = from.Message,
                Type = (Facade.LogEntryType)Enum.Parse(typeof(Facade.LogEntryType), from.Type.ToString())
            };

            return entry;
        }
    }
}
