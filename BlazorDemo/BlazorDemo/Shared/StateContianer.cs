namespace BlazorDemo.Shared
{
    public class StateContianer
    {
        public People Value { get; set; }
        public event Action OnStateChange;
        public void SetValue(People value)
        { 
            this.Value = value;
            NotifyStateChanged(); 
        }

        private void NotifyStateChanged()
        {
            OnStateChange?.Invoke(); 
        }
    }
}
