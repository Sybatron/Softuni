class Article {
    ReplyClass = class Reply {
        constructor(id, username, content) {
            this.id = id;
            this.username = username;
            this.content = content;
        }
    };

    CommentClass = class Comment {
        replies = [];
        constructor(id, username, content) {
            this.id = id;
            this.username = username;
            this.content = content;
        }
    };

    _comments = [];
    _likes = [];
    constructor(title, creator) {
        this.title = title;
        this.creator = creator;
    }

    get likes() {
        if (this._likes.length === 0) {
            return `${this.title} has 0 likes`;
        }

        if (this._likes.length === 1) {
            return `${this._likes[0]} likes this article!`;
        }

        return `${this._likes[0]} and ${likes} others like this article!`
    }

    like(username) {
        if (this._likes.includes(username)) {
            throw Error("You can't like the same article twice!");
        }

        if (this.creator === username) {
            throw Error("You can't like your own articles!");
        }

        this._likes.push(username);
        return `${username} liked ${this.title}!`;
    }

    dislike(username) {
        if (!this._likes.includes(username)) {
            throw Error("You can't dislike this article!");
        }

        this._likes.splice(this._likes.indexOf(username), 1);
        return `${username} disliked ${this.title}`;
    }

    comment(username, content, id) {
        if (id === undefined) {
            id = this._comments.length+1;
        }

        let comment = this._comments.filter(obj => obj.id === id)[0];
        if (!comment) {
            this._comments.push(new this.CommentClass(id, username, content));
            return `${username} commented on ${this.title}`;
        }


        if (comment) {
            let commentReplies = comment.replies.filter(obj => obj.id.split('.')[0] === id);

            let replyId;
            if (commentReplies.length === 0) {
                replyId = `${id}.1`;
            } else {
                replyId = commentReplies[commentReplies.length - 1].id;
                let idParts = replyId.split('.');
                replyId = `${idParts[0]}.${(Number(idParts[1]) + 1)}`;
            }
            let reply = new this.ReplyClass(replyId, username, content);
            this._comments[comment.id-1].replies.push(reply);
            return "You replied successfully";
        }
    }

    //TODO toString
    toString(sortingType) {
        if (sortingType === 'asc') {
            function sortId(a, b) {
                return a.id - b.id;
            }

            this._comments = this._comments.sort(sortId);
            this._comments.forEach(currentComment => currentComment.replies = currentComment.replies.sort(sortId));
        } else if (sortingType === 'desc') {

        } else if (sortingType === 'username') {

        }
    }
}

let art = new Article("My Article", "Anny");
art.like("John");
console.log(art.likes);
art.dislike("John");
console.log(art.likes);
art.comment("Sammy", "Some Content");
console.log(art.comment("Ammy", "New Content"));
art.comment("Zane", "Reply", 1);
art.comment("Jessy", "Nice :)");
console.log(art.comment("SAmmy", "Reply@", 1));
console.log()
console.log(art.toString('username'));
console.log()
art.like("Zane");
console.log(art.toString('desc'));