import styles from "./Card.module.scss"
export default function Card(props) {
    const noSortIngredient = props.ingredients
    const sortIngredient = noSortIngredient.split('-').slice(1)




    
    return (
        
        <div onClick={props.onClick} className={styles.card}>
            <img src={props.img} alt="" />
            <h2>{props.name}</h2>
            <div>
                {sortIngredient.map((obj, index) => (
                    <p key={index}>-{obj}</p>
                ))}
                {/* <p>{props.ingredients}</p> */}
            </div>
        </div>
    )
}