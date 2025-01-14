public class MyStack {

    Queue<int> queue;

    public MyStack() {
        queue = new Queue<int>();
    }
    
    public void Push(int x) {
        queue.Enqueue(x);

        var count = queue.Count -1;
        while(count > 0)
        {
            queue.Enqueue(queue.Dequeue());
            count--;
        }
    }
    
    public int Pop() {
        if(queue.Count == 0) return 0;
        return queue.Dequeue();
    }
    
    public int Top() {
        if(queue.Count == 0) return 0;
        
        return queue.Peek();
    }
    
    public bool Empty() {
        return queue.Count == 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */