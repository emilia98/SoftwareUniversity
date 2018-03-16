function solve(){
    class Post{
        constructor(title, content){
            this.title = title;
            this.content = content;
        }

        toString(){
            return [`Post: ${this.title}`, `Content: ${this.content}`].join('\n');
        }
    }

    class SocialMediaPost extends Post{
        constructor(title, content, likes, dislikes){
            super(title, content);
            this.likes = likes;
            this.dislikes = dislikes;
            this.comments = [];
        }

        addComment(comment){
            this.comments.push(comment);
        }

        toString(){
            let toPrint = super.toString().split('\n');
            toPrint.push(`Rating: ${this.likes - this.dislikes}`);

            if(this.comments.length > 0){
                toPrint.push("Comments:");
                for(let comment of this.comments){
                    toPrint.push(` * ${comment}`);
                }
            }
            return toPrint.join("\n");
        }
    }

    class BlogPost extends Post{
        constructor(title, content, views){
            super(title, content);
            this.views = views;
        }

        view(){
            this.views++;
            return this; // returns the object itself, so we can chain functions
        }

        toString(){
            let toPrint = super.toString().split('\n');
            toPrint.push(`Views: ${this.views}`);
            return toPrint.join('\n');
        }
    }

    return {
        Post,
        SocialMediaPost,
        BlogPost
    };
}

/* Uncomment to test:
let result = solve();
let Post = result.Post;
let SocialMediaPost = result.SocialMediaPost;
let BlogPost = result.BlogPost;

let post = new Post("Post", "Content");
console.log(post.toString());
// Post: Post
// Content: Content

let scm = new SocialMediaPost("TestTitle", "TestContent", 25, 30);
scm.addComment("Good post");
scm.addComment("Very good post");
scm.addComment("Wow!");
console.log(scm.toString());
// Post: TestTitle
// Content: TestContent
// Rating: -5
// Comments:
//  * Good post
//  * Very good post
//  * Wow!

let blogPost = new BlogPost("BlogTitle", "BlogContent", 2);
blogPost.view();
blogPost.view();
console.log(blogPost.view().toString());
// Post: BlogTitle
// Content: BlogContent
// Views: 5
*/

