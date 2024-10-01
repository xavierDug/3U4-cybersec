from flask import Flask, request, render_template

app = Flask(__name__)

# create a static list to store posts as strings
posts = ["gna", "gros"]


@app.route('/create_post', methods=['GET', 'POST'])
def create_post():
    if request.method == 'POST':
        #title = request.form['title']
        content = request.form['content']
        # Here you would typically save the post to a database
        # redirect to the home page
        posts.append(content)
        return hello_world()
        #return f'Post created:  {content}'
    else:
        # return the create_post template
        return render_template('create_post.html')
@app.route('/')
def hello_world():  # put application's code here
    html = '<html><head><meta charset="UTF-8"><title>Home</title></head><body>    <h1>Mon super forum</h1>   <p>Bienvenue, </p><a href="/create_post">Nouveau message anonyme</a><h2>Messages</h2>'
    for post in posts:
        html += f'<p>{post}</p>'
    html += '</body></html>'
    return html

# @app.route('/')
# def hello_world():  # put application's code here
#     # return the home template with the posts list
#     return render_template('home.html', posts=posts)


if __name__ == '__main__':
    app.run(host='0.0.0.0')
