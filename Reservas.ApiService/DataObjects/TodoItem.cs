﻿using Microsoft.WindowsAzure.Mobile.Service;

namespace Reservas.ApiService.DataObjects
{
    public class TodoItem : EntityData
    {
        public string Text { get; set; }

        public bool Complete { get; set; }
    }
}