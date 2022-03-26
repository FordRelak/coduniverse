import { Spaceobject } from "./spaceobject";

export class StarSystem {
    constructor(
        public id: string,
        public spaceObjects: Spaceobject[],
        public name: string,
        public type: number,
        public typeName: string,
        public age: number,
        public centerMass: Spaceobject
    ) { }

}
