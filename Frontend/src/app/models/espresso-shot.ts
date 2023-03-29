export enum Flavour {
    VeryAcidic = 1,
    SlightlyAcidic = 2,
    BalancedFlavour = 3,
    SlightlyBitter = 4,
    VeryBitter = 5
}

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