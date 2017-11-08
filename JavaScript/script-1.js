// inputs
let quantity = 20000; // total quantity
let density = 8000; // density of the material in kg/m3
let thickness = 4; // in millimeters
let outerDiameter = 8, innerDiameter = 3; // in millimeters

// calculations

let innerArea = Math.PI * (innerDiameter / 1000 / 2) * (innerDiameter / 1000 / 2);
let outerArea = Math.PI * (outerDiameter / 1000 / 2) * (outerDiameter / 1000 / 2);
let area = outerArea - innerArea;
let volume = thickness / 1000 * area;
let weight = density * volume;
let totalWeight = quantity * weight;

// output
console.log(`weight of a single flat washers is ${weight*1000} g`);
console.log(`total weight of ${quantity} flat washers is ${totalWeight} kg`);
