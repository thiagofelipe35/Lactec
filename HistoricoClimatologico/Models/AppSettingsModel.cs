using System.Collections.Generic;

namespace HistoricoClimatologico.Models
{
    public class AppSettingsVO
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public List<string> Scope { get; set; }
        public string AccessKey { get; set; }
        public string BigBrainUrl { get; set; }
        public string TenantId { get; set; }
    }
}
