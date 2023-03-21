﻿using Xamarin.Forms;

namespace SmartSchoolsV2.Behaviors
{
    public class CardNumberMaskBehavior : Behavior<Entry>
    {
        public static CardNumberMaskBehavior Instance = new CardNumberMaskBehavior();

        ///  
        /// Attaches when the page is first created.  
        ///   

        protected override void OnAttachedTo(Entry entry)
        {
            entry.TextChanged += OnEntryTextChanged;
            base.OnAttachedTo(entry);
        }

        ///  
        /// Detaches when the page is destroyed.  
        ///   

        protected override void OnDetachingFrom(Entry entry)
        {
            entry.TextChanged -= OnEntryTextChanged;
            base.OnDetachingFrom(entry);
        }

        private void OnEntryTextChanged(object sender, TextChangedEventArgs args)
        {
            if (!string.IsNullOrWhiteSpace(args.NewTextValue))
            {
                // If the new value is longer than the old value, the user is  
                if (args.OldTextValue != null && args.NewTextValue.Length < args.OldTextValue.Length)
                    return;

                var value = args.NewTextValue;

                if (value.Length == 4)
                {
                    ((Entry)sender).Text += " ";
                    return;
                }

                if (value.Length == 9)
                {
                    ((Entry)sender).Text += " ";
                    return;
                }

                if (value.Length == 14)
                {
                    ((Entry)sender).Text += " ";
                    return;
                }

                ((Entry)sender).Text = args.NewTextValue;
            }
        }
    }
}
