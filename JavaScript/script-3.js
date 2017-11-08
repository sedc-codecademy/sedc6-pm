function drawShapes(){
    drawRocket();
    drawSeparator();
    drawMaleFigure();
    drawSeparator();
    drawFemaleFigure();
}

function drawSeparator(){
    console.log("===========");
}

function drawRocket(){
    drawTriangle();
    drawSquare();
    drawInvertedV();
}

function drawMaleFigure(){
    drawCircle();
    drawSquare();
    drawInvertedV();
}

function drawFemaleFigure(){
    drawCircle();
    drawTriangle();
    drawInvertedV();
}

function drawTriangle(){
    console.log("    *    ");
    console.log("   * *   ");
    console.log("  *   *  ");
    console.log(" *     * ");
    console.log("*********");
}

function drawSquare(){
    console.log("*********");
    console.log("*       *");
    console.log("*       *");
    console.log("*       *");
    console.log("*********");
}

function drawInvertedV(){
    console.log("    *    ");
    console.log("   * *   ");
    console.log("  *   *  ");
    console.log(" *     * ");
    console.log("*       *");
}

function drawCircle(){
    console.log("   ***   ");
    console.log(" *     * ");
    console.log("(       )");
    console.log(" *     *");
    console.log("   ***   ");
}

drawShapes();

