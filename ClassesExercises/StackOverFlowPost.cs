namespace Examples.ClassesExercises
{
    public class StackOverFlowPost
    {
        private int upvote, downvote = 0;

        public void Voting(Post post)
        {
            while (true)
            {
                Console.WriteLine($"Vote for the post {post.Title} , 1 For Up and 0 for down");
                var input = Convert.ToInt32(Console.ReadLine());

                if (input == 1)
                {
                    upvote++;
                }
                else if (input == 0)
                { downvote++; }
                else
                {
                    Console.WriteLine($"vote count is upvotes - {upvote} and downvotes- {downvote} ");
                    break;
                }
            }
        }
    }

    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public DateTime Created { get; set; }
    }
}