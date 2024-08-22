<!DOCTYPE html>
<html>
<head>
    <title>Login Form</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Login Form</h2>
            <label for="username">Username:</label>
            <input type="text" id="username" name="username" required /><br /><br />
            
            <label for="password">Password:</label>
            <input type="password" id="password" name="password" required /><br /><br />
            
            <input type="submit" value="Login" />
        </div>
    </form>
    
    <div>
        <a href="default.aspx">Back to Home</a>
    </div>
</body>
</html>
