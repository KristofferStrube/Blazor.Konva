export function createStage(container, width, height) {
    return new Konva.Stage({
        container: container,
        width: width,
        height: height
    });
}

export function createLayer() {
    return new Konva.Layer();
}

export function createCircle(x, y, radius, fill, stroke, strokeWidth) {
    return new Konva.Circle({
        x: x,
        y: y,
        radius: radius,
        fill: fill,
        stroke: stroke,
        strokeWidth: strokeWidth
    });
}

export function add(parent, child) {
    parent.add(child);
}

export function draw(objectReference) {
    objectReference.draw();
}