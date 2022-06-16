﻿using System;
using System.Data;

namespace CafeShop.DTO {
    public class Bill {
        private int id;
        private DateTime? dateCheckIn;
        private DateTime? dateCheckOut;
        private int status;
        private int discount;

      

        public Bill(int id,DateTime? dateCheckIn,DateTime? dateCheckOut,int status) {
            this.id = id;
            this.dateCheckIn = dateCheckIn;
            this.dateCheckOut = dateCheckOut;
            this.status = status;
            this.Discount = discount;
        }
        public Bill(DataRow row) {
            this.Id =  (int)row["id"];
            this.DateCheckIn = (DateTime?)row["dateCheckIn"];
            var dateCheckOutTemp = row["dateCheckOut"];
            if (dateCheckOutTemp.ToString() != "") {
                this.DateCheckOut = (DateTime?)dateCheckOutTemp;
            }
            
            this.Status = (int)row["status"];
            if (row["discount"].ToString() != "") {
                this.Discount = (int)row["discount"];
            }
            
        }

        public int Id {
            get => id;
            set => id = value;
        }
        public DateTime? DateCheckIn {
            get => dateCheckIn;
            set => dateCheckIn = value;
        }
        public DateTime? DateCheckOut {
            get => dateCheckOut;
            set => dateCheckOut = value;
        }
        public int Status {
            get => status;
            set => status = value;
        }
        public int Discount {
            get => discount;
            set => discount = value;
        }
    }
}
