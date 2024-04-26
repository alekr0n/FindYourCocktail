import React from 'react';
import styles from "./NameModal.module.scss"
import UnsetButton from '../UnsetButton/UnsetButton';

export default function NameModal( {  onClickModal, object  } ) {



    return (
        <div className={styles.namemodal__overlay}>
            <div className={styles.namemodal__content}>
                <div className={styles.namemodal__imgcontainer}><img className={styles.namemodal__img} src={object.img} alt="" /></div>
                <h2 className={styles.namemodal__name}>{object.name}</h2>
                <p>{object.ingredients}</p>
                <button className={styles.namemodal__close} onClick = {onClickModal}>&#x2716;</button>
                <div className={styles.namemodal__main}>
                    <div className={styles.namemodal__story}>
                        <textarea placeholder='Enter your story or descriptions...' name="" id="" cols="" rows=""></textarea>
                        <UnsetButton text="Add Description" />
                    </div>
                    <div className={styles.namemodal__rateinfo}>
                        <h2 className={styles.namemodal__rate}>Rate:</h2>
                        <div>
                            <select name="" id="">
                                <option value="1">1</option>
                                <option value="2">2</option>
                                <option value="3">3</option>
                                <option value="4">4</option>
                                <option value="5">5</option>
                            </select>
                            <h2>/5</h2>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    );
}
