﻿/*
 * Copyright (C) Sportradar AG. See LICENSE for full license governing this code
 */

//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v8.6.6263.34621 (http://NJsonSchema.org)
// </auto-generated>
//----------------------

using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Sportradar.MTS.SDK.Entities.Internal.Dto.TicketCashout
{
    #pragma warning disable // Disable all warnings

    /// <summary>Ticket cashout version 2.4 schema</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.6.6263.34621")]
    internal partial class TicketCashoutDTO : System.ComponentModel.INotifyPropertyChanged
    {
        private long _timestampUtc;
        private string _ticketId;
        private Sender _sender = new Sender();
        private long? _cashoutStake;
        private int? _cashoutPercent;
        private IEnumerable<Anonymous> _betCashout = new Collection<Anonymous>();
        private string _version;
    
        /// <summary>Timestamp of ticket cashout placement (in UNIX time millis)</summary>
        [Newtonsoft.Json.JsonProperty("timestampUtc", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(1.0, 9223372036854775807.0)]
        public long TimestampUtc
        {
            get { return _timestampUtc; }
            set 
            {
                if (_timestampUtc != value)
                {
                    _timestampUtc = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        /// <summary>Ticket id to cashout</summary>
        [Newtonsoft.Json.JsonProperty("ticketId", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(128, MinimumLength = 1)]
        public string TicketId
        {
            get { return _ticketId; }
            set 
            {
                if (_ticketId != value)
                {
                    _ticketId = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        /// <summary>Identification and settings of the cashout sender</summary>
        [Newtonsoft.Json.JsonProperty("sender", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Sender Sender
        {
            get { return _sender; }
            set 
            {
                if (_sender != value)
                {
                    _sender = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        /// <summary>Cashout stake in same currency as original ticket. Quantity multiplied by 10_000 and rounded to a long value. Applicable only if performing full cashout.</summary>
        [Newtonsoft.Json.JsonProperty("cashoutStake", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(1.0, 1000000000000000000.0)]
        public long? CashoutStake
        {
            get { return _cashoutStake; }
            set 
            {
                if (_cashoutStake != value)
                {
                    _cashoutStake = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        /// <summary>Cashout percent. Quantity multiplied by 10_000 and rounded to a long value. Percent of ticket to cashout. Max 100%.</summary>
        [Newtonsoft.Json.JsonProperty("cashoutPercent", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(1.0, 1000000.0)]
        public int? CashoutPercent
        {
            get { return _cashoutPercent; }
            set 
            {
                if (_cashoutPercent != value)
                {
                    _cashoutPercent = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        /// <summary>Array of (betId, cashoutStake) pairs, if performing partial cashout. Applicable only if ticket-level cashout stake is null.</summary>
        [Newtonsoft.Json.JsonProperty("betCashout", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IEnumerable<Anonymous> BetCashout
        {
            get { return _betCashout; }
            set 
            {
                if (_betCashout != value)
                {
                    _betCashout = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        /// <summary>JSON format version (must be '2.4')</summary>
        [Newtonsoft.Json.JsonProperty("version", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(3, MinimumLength = 3)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^(2\.4)$")]
        public string Version
        {
            get { return _version; }
            set 
            {
                if (_version != value)
                {
                    _version = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static TicketCashoutDTO FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<TicketCashoutDTO>(data);
        }
    
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.6.6263.34621")]
    internal partial class Sender : System.ComponentModel.INotifyPropertyChanged
    {
        private int _bookmakerId;
    
        /// <summary>Client's id (provided by Sportradar to the client)</summary>
        [Newtonsoft.Json.JsonProperty("bookmakerId", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(1.0, 2147483647.0)]
        public int BookmakerId
        {
            get { return _bookmakerId; }
            set 
            {
                if (_bookmakerId != value)
                {
                    _bookmakerId = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Sender FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Sender>(data);
        }
    
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.6.6263.34621")]
    internal partial class Anonymous : System.ComponentModel.INotifyPropertyChanged
    {
        private string _id;
        private long _cashoutStake;
        private int? _cashoutPercent;
    
        /// <summary>Bet id</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(128, MinimumLength = 1)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^[0-9A-Za-z:\-_]{1,128}$")]
        public string Id
        {
            get { return _id; }
            set 
            {
                if (_id != value)
                {
                    _id = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        /// <summary>Cashout stake in same currency as original ticket. Quantity multiplied by 10_000 and rounded to a long value.</summary>
        [Newtonsoft.Json.JsonProperty("cashoutStake", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(1.0, 1000000000000000000.0)]
        public long CashoutStake
        {
            get { return _cashoutStake; }
            set 
            {
                if (_cashoutStake != value)
                {
                    _cashoutStake = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        /// <summary>Cashout percent. Quantity multiplied by 10_000 and rounded to a long value. Percent of bet to cashout. Max 100%.</summary>
        [Newtonsoft.Json.JsonProperty("cashoutPercent", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(1.0, 1000000.0)]
        public int? CashoutPercent
        {
            get { return _cashoutPercent; }
            set 
            {
                if (_cashoutPercent != value)
                {
                    _cashoutPercent = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Anonymous FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Anonymous>(data);
        }
    
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    }
}