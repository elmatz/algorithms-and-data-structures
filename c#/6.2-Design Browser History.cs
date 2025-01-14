public class Page{
    public string url;
    public Page next;
    public Page prev;

    public Page(string url, Page next, Page prev){
        this.url = url;
        this.next = next;
        this.prev = prev;
    }
}

public class BrowserHistory {

    public Page curr;

    public BrowserHistory(string homepage) {
        curr = new Page(homepage, null, null);
    }
    
    public void Visit(string url) {
        curr.next = new Page(url, null, curr);
        curr = curr.next;        
    }
    
    public string Back(int steps) {
        
        if(curr == null || steps < 1) return "";
        
        while(steps > 0){
            if(curr.prev == null) break;
            curr = curr.prev;
            steps--;
        }

        return curr != null ? curr.url : "";
        
    }
    
    public string Forward(int steps) {
        if(curr == null || steps < 1) return "";
        
        while(steps > 0){
            if(curr.next == null) break;
            curr = curr.next;
            steps--;
        }

        return curr != null ? curr.url : "";
    }
}

/**
 * Your BrowserHistory object will be instantiated and called as such:
 * BrowserHistory obj = new BrowserHistory(homepage);
 * obj.Visit(url);
 * string param_2 = obj.Back(steps);
 * string param_3 = obj.Forward(steps);
 */