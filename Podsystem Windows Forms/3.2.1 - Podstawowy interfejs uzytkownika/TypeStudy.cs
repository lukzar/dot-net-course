using System;

namespace PodstawowyInterfejsUzytkownika
{
    public enum Study
    { 
        BACHELOR = 1,
        MASTER = 2,
    }

    class TypeStudy
    {
        public Study ID 
        { 
            get; 
            set; 
        }

        public string Description 
        { 
            get; 
            set; 
        }
    }
}
