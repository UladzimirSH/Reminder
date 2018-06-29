using System.ComponentModel;

namespace Common.Enums {    
    public enum Priority {
        [Description("Urgent")]
        Urgent = 0,
        [Description("Must to do")]
        MustToDo = 1,
        [Description("Should to do")]
        ShouldToDo = 2,
        [Description("Nice to do")]
        NiceToDo = 3,
        [Description("Background")]
        Background = 4
    }
}
