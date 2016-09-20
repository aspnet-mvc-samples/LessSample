# LessSample

dotLess パッケージにより簡単に LESS を組み込むことができます。

## 今回の組み込み例
app.less
```less
.jumbotron{
    h1{
        color: red;
    }
    p{
        color: blue;
    }
}
```
↓
変換結果
```less
.jumbotron h1 {
    color: red;
}
.jumbotron p {
    color: blue;
}
```
