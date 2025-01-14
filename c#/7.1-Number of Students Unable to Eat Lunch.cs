public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {

        var studentsQueue = new Queue<int>(students);
        var sandwichesQueue = new Queue<int>(sandwiches);
        
        var length = studentsQueue.Count;
        while(length > 0){
            var student = studentsQueue.Dequeue();

            if(student == sandwichesQueue.Peek()){
                length = studentsQueue.Count;
                sandwichesQueue.Dequeue();
            }
            else{
                studentsQueue.Enqueue(student);
                length--;
            }
            
        }

        return studentsQueue.Count;
    }
}