using System;

[Serializable]
public class Observable<T>
{
    private T value;
    public event Action<T> ValueChanged;

    public T Value
    {
        get => value;
        set => Set(value);
    }

    // Use var to get value instead of var.value
    public static implicit operator T(Observable<T> observable) => observable.value;

    public Observable(T value, Action<T> onValueChanged = null) 
    {
        this.value = value;
        
        if (onValueChanged != null)
        {
            ValueChanged += onValueChanged;
        }
    }

    public void Set(T value)
    {
        // Value didn't change
        if (Equals(this.value, value)) return;

        this.value = value;
        Invoke();
    }

    public void Invoke()
    {
        ValueChanged?.Invoke(value);
    }

    public void AddListener(Action<T> handler)
    {
        ValueChanged += handler;
    }

    public void RemoveListener(Action<T> handler)
    {
        ValueChanged -= handler;
    }
    public void Dispose()
    {
        ValueChanged = null;
        value = default;
    }
}
