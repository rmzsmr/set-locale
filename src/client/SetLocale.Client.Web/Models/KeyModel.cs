﻿using System.Collections.Generic;

namespace SetLocale.Client.Web.Models
{
    public class KeyModel : BaseModel
    {
        
        public string Key { get; set; }
        public string Description { get; set; }
        public bool IsTranslated { get; set; }
        public List<TagModel> Tags { get; set; }
        public List<LanguageModel> Languages {get; set;}
        public List<TranslationModel> Translations { get; set; }
    }
}