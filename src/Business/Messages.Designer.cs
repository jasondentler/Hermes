﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TellagoStudios.Hermes.Business {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Messages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Messages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TellagoStudios.Hermes.Business.Messages", typeof(Messages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument was empty..
        /// </summary>
        public static string ArgumentWasEmpty {
            get {
                return ResourceManager.GetString("ArgumentWasEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument was empty or whitespace..
        /// </summary>
        public static string ArgumentWasEmptyOrWhitespace {
            get {
                return ResourceManager.GetString("ArgumentWasEmptyOrWhitespace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument was invalid..
        /// </summary>
        public static string ArgumentWasInvalid {
            get {
                return ResourceManager.GetString("ArgumentWasInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument was null..
        /// </summary>
        public static string ArgumentWasNull {
            get {
                return ResourceManager.GetString("ArgumentWasNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The callback&apos;s kind &apos;{0}&apos; is unknown..
        /// </summary>
        public static string CallbackKindUnknown {
            get {
                return ResourceManager.GetString("CallbackKindUnknown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find an entity of type {0} with id =&apos;{1}&apos;..
        /// </summary>
        public static string EntityNotFound {
            get {
                return ResourceManager.GetString("EntityNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error ocurred trying to push callback to suscriber.
        ///Message : {0}. 
        ///Subscription : {1}.
        /// </summary>
        public static string ErrorPushingCallback {
            get {
                return ResourceManager.GetString("ErrorPushingCallback", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Group Id &apos;{0}&apos; appears twice in a single group hierarchy..
        /// </summary>
        public static string GroupCircleReference {
            get {
                return ResourceManager.GetString("GroupCircleReference", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The group with id = &apos;{0}&apos; contains sub-groups. Delete all sub-groups before deleting. the group..
        /// </summary>
        public static string GroupContainsChildGroups {
            get {
                return ResourceManager.GetString("GroupContainsChildGroups", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The group with id = &apos;{0}&apos; contains topics. Delete all topics before deleting the group..
        /// </summary>
        public static string GroupContainsChildTopics {
            get {
                return ResourceManager.GetString("GroupContainsChildTopics", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Group property must not be null..
        /// </summary>
        public static string GroupMustNotBeNull {
            get {
                return ResourceManager.GetString("GroupMustNotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Already exists a topic group with name &apos;{0}&apos;..
        /// </summary>
        public static string GroupNameMustBeUnique {
            get {
                return ResourceManager.GetString("GroupNameMustBeUnique", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Id property must not be null..
        /// </summary>
        public static string IdMustNotBeNull {
            get {
                return ResourceManager.GetString("IdMustNotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified filter is invalid {0}..
        /// </summary>
        public static string InvalidFilter {
            get {
                return ResourceManager.GetString("InvalidFilter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MessageId property must not be null..
        /// </summary>
        public static string MessageIdMustNotBeNull {
            get {
                return ResourceManager.GetString("MessageIdMustNotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Name must not be null nor empty..
        /// </summary>
        public static string NameMustBeNotNull {
            get {
                return ResourceManager.GetString("NameMustBeNotNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ReceivedOn property must be setted..
        /// </summary>
        public static string ReceivedOnMustBeSetted {
            get {
                return ResourceManager.GetString("ReceivedOnMustBeSetted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TargetId property must not be null..
        /// </summary>
        public static string TargetIdMustNotBeNull {
            get {
                return ResourceManager.GetString("TargetIdMustNotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The target&apos;s kind &apos;{0}&apos; is unknown..
        /// </summary>
        public static string TargetKindUnknown {
            get {
                return ResourceManager.GetString("TargetKindUnknown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TopicId property must not be null..
        /// </summary>
        public static string TopicIdMustNotBeNull {
            get {
                return ResourceManager.GetString("TopicIdMustNotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Already exists a topic with name &apos;{0}&apos;..
        /// </summary>
        public static string TopicNameMustBeUnique {
            get {
                return ResourceManager.GetString("TopicNameMustBeUnique", resourceCulture);
            }
        }
    }
}