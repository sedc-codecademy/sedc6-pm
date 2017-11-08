// ==============================

function calculateWeight(density, thickness, outerDiameter, innerDiameter){
    let volume = calculateCilinderVolume(thickness, outerDiameter, innerDiameter);
    return density * volume;
}

function calculateCilinderVolume(height, outerDiameter, innerDiameter){
    var baseArea = getCircleArea(outerDiameter) - getCircleArea(innerDiameter);
    return baseArea * height;    
}

function getCircleArea(diameter){
    var radius = diameter / 2;
    var area = Math.PI * Math.pow(radius,2);
    return area;
}
// ==============================


// inputs
let quantity = 20000; // total quantity
let density = 8000; // density of the material in kg/m3
let thickness = 4; // in millimeters
let outerDiameter = 8, innerDiameter = 3; // in millimeters

// calculations
let weight = calculateWeight(density, thickness / 1000, outerDiameter / 1000,  innerDiameter / 1000)
let totalWeight = quantity * weight;
// output
console.log(`weight of a single flat washers is ${weight*1000} g`);
console.log(`total weight of ${quantity} flat washers is ${totalWeight} kg`);

