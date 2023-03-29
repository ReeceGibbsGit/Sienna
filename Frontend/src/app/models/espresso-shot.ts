export interface EspressoShot {
    id: string;
    beanType?: string;
    grind: number;
    beans: number;
    pressure: number;
    water: number;
    brewTime: number;
    flavour: number;
    rating: number;
    comments?: string;
}