import { Pipe, PipeTransform } from '@angular/core';

/**
 * This is a custom pipe that takes in a camel case string and adds a space before every uppercose letter
 */
@Pipe({ name: 'camelSpace' })

export class CamelSpace implements PipeTransform {
    *transformChar(value: string) {
        for (let i = 0; i < value.length; i++) {
            const charAscii = value.charCodeAt(i);
            yield charAscii > 64 && charAscii < 91 ? ` ${value[i]}` : value[i];
        }
    }

    transform(value: string): string {
        return Array.from(this.transformChar(value)).join('');
    }
}